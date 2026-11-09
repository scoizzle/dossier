# Fact c37678b7

Store id: 15e8489f-f98c-411c-bd9e-b2216940fbc1

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
- posted_at: `2026-11-09T23:44:48.4009240+00:00`

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
  "id": "15e8489f-f98c-411c-bd9e-b2216940fbc1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4009240+00:00"
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
  "subject_id": "65080d62-812b-4b74-92c1-60c43628e75a",
  "subject_name": "django/db/models/aggregates::Count",
  "tags": [
    "entity:class"
  ],
  "text": "class Count(Aggregate)"
}
```
