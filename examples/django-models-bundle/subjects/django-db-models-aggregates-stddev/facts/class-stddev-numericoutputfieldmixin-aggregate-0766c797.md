# Fact 0766c797

Store id: 24efb5b4-f9ef-470d-9b9a-e8358960a877

## Text

```text
class StdDev(NumericOutputFieldMixin, Aggregate)
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
- posted_at: `2026-11-09T23:31:53.5411420+00:00`

## Data

```json
{
  "end_line": 349,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 340,
  "symbol": "StdDev"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":340,"selector":"L340-L349","symbol":"StdDev"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StdDev](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 349,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 340,
    "symbol": "StdDev"
  },
  "id": "24efb5b4-f9ef-470d-9b9a-e8358960a877",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5411420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 340,
        "selector": "L340-L349",
        "symbol": "StdDev"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "8ce29e24-e789-4658-bd85-9162b146b4e5",
  "subject_name": "django/db/models/aggregates::StdDev",
  "tags": [
    "entity:class"
  ],
  "text": "class StdDev(NumericOutputFieldMixin, Aggregate)"
}
```
