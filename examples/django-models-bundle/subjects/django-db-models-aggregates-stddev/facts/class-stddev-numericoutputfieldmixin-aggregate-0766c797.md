# Fact 0766c797

Store id: 0f16a439-e98e-4027-9a2b-95fdac8e7c56

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
- posted_at: `2026-11-09T22:39:40.0452670+00:00`

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
  "id": "0f16a439-e98e-4027-9a2b-95fdac8e7c56",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0452670+00:00"
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
  "subject_id": "3eed5fe4-6dfe-416b-b67a-3db791340b74",
  "subject_name": "django/db/models/aggregates::StdDev",
  "tags": [
    "entity:class"
  ],
  "text": "class StdDev(NumericOutputFieldMixin, Aggregate)"
}
```
