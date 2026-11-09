# Fact c6c4efe4

Store id: 368bae9d-b722-49c5-a9c9-2088d2495f5b

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
- posted_at: `2026-11-09T22:39:46.1931270+00:00`

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
  "id": "368bae9d-b722-49c5-a9c9-2088d2495f5b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1931270+00:00"
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
  "subject_id": "56cd9926-376d-410d-bd01-5b80a9de5430",
  "subject_name": "django/db/models/functions/datetime::TruncQuarter",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncQuarter(TruncBase)"
}
```
