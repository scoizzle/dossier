# Fact 8a951891

Store id: ba1272d2-34b7-478c-812d-fdef28ba2f7c

## Text

```text
class TruncMinute(TruncBase)
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
- posted_at: `2026-11-09T22:39:46.2164120+00:00`

## Data

```json
{
  "end_line": 412,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 411,
  "symbol": "TruncMinute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":411,"selector":"L411-L412","symbol":"TruncMinute"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncMinute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 412,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 411,
    "symbol": "TruncMinute"
  },
  "id": "ba1272d2-34b7-478c-812d-fdef28ba2f7c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.2164120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 411,
        "selector": "L411-L412",
        "symbol": "TruncMinute"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "5d61f2b0-f22e-4033-ad7e-39ec129daa06",
  "subject_name": "django/db/models/functions/datetime::TruncMinute",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncMinute(TruncBase)"
}
```
