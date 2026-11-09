# Fact a6191f79

Store id: ee36049f-5084-4ebf-85e8-3900eb75051b

## Text

```text
class TruncWeek(TruncBase)
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
- posted_at: `2026-11-09T23:32:01.2815760+00:00`

## Data

```json
{
  "end_line": 376,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 373,
  "symbol": "TruncWeek"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":373,"selector":"L373-L376","symbol":"TruncWeek"}`

## Items

```json
[
  {
    "text": "Truncate to midnight on the Monday of the week.",
    "locator": {
      "line": 374
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncWeek](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 376,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 373,
    "symbol": "TruncWeek"
  },
  "id": "ee36049f-5084-4ebf-85e8-3900eb75051b",
  "items": [
    {
      "locator": {
        "line": 374
      },
      "text": "Truncate to midnight on the Monday of the week."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2815760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 373,
        "selector": "L373-L376",
        "symbol": "TruncWeek"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "17816aae-c297-4b0f-a2fe-5365dcfabc39",
  "subject_name": "django/db/models/functions/datetime::TruncWeek",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncWeek(TruncBase)"
}
```
