# Fact c6c4efe4

Store id: d9823e49-2bab-4a44-b716-8853b2026dee

## Text

```text
class TruncQuarter(TruncBase)
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
- posted_at: `2026-11-09T23:32:01.2761570+00:00`

## Data

```json
{
  "end_line": 366,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 365,
  "symbol": "TruncQuarter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":365,"selector":"L365-L366","symbol":"TruncQuarter"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncQuarter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 366,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 365,
    "symbol": "TruncQuarter"
  },
  "id": "d9823e49-2bab-4a44-b716-8853b2026dee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2761570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 365,
        "selector": "L365-L366",
        "symbol": "TruncQuarter"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "2f5fff05-2c12-43c7-b20b-12ed46ad1162",
  "subject_name": "django/db/models/functions/datetime::TruncQuarter",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncQuarter(TruncBase)"
}
```
