# Fact abc66a46

Store id: 50744df2-1b1b-49d5-a8ff-e82b5a54d182

## Text

```text
class TruncTime(TruncBase)
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
- posted_at: `2026-11-09T23:44:53.4092250+00:00`

## Data

```json
{
  "end_line": 404,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 395,
  "symbol": "TruncTime"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":395,"selector":"L395-L404","symbol":"TruncTime"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncTime](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 404,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 395,
    "symbol": "TruncTime"
  },
  "id": "50744df2-1b1b-49d5-a8ff-e82b5a54d182",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.4092250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 395,
        "selector": "L395-L404",
        "symbol": "TruncTime"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "e4ea9ecd-5fc0-45ef-9691-7a0741ae814b",
  "subject_name": "django/db/models/functions/datetime::TruncTime",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncTime(TruncBase)"
}
```
