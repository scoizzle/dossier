# Fact c37678b7

Store id: 0c1b0d35-0197-4be9-b6cc-8fa5da39f12a

## Text

```text
class Count(Aggregate)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.5391420+00:00`

## Data

```json
{
  "end_line": 325,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 295,
  "symbol": "Count"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":295,"selector":"L295-L325","symbol":"Count"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Count](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 325,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 295,
    "symbol": "Count"
  },
  "id": "0c1b0d35-0197-4be9-b6cc-8fa5da39f12a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5391420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 295,
        "selector": "L295-L325",
        "symbol": "Count"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "bcd3907f-cca0-4ee9-93a9-4ec8de62b68f",
  "subject_name": "django/db/models/aggregates::Count",
  "tags": [
    "entity:class"
  ],
  "text": "class Count(Aggregate)"
}
```
