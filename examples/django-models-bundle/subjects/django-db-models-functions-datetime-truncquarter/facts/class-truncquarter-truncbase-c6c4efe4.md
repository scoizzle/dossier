# Fact c6c4efe4

Store id: 9da36cd4-46e8-4e12-bec5-cea4bc93f621

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
- posted_at: `2026-11-09T23:44:53.3967700+00:00`

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
  "id": "9da36cd4-46e8-4e12-bec5-cea4bc93f621",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3967700+00:00"
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
  "subject_id": "d4e724f9-8d4f-4cf4-aab5-55b8451af961",
  "subject_name": "django/db/models/functions/datetime::TruncQuarter",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncQuarter(TruncBase)"
}
```
