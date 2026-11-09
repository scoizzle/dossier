# Fact 07f34064

Store id: ea15ee26-8339-4603-a334-35bb97dd7bba

## Text

```text
class ExtractMinute(Extract)
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
- posted_at: `2026-11-09T23:32:01.2214710+00:00`

## Data

```json
{
  "end_line": 176,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 175,
  "symbol": "ExtractMinute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":175,"selector":"L175-L176","symbol":"ExtractMinute"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractMinute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 176,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 175,
    "symbol": "ExtractMinute"
  },
  "id": "ea15ee26-8339-4603-a334-35bb97dd7bba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2214710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 175,
        "selector": "L175-L176",
        "symbol": "ExtractMinute"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "b073442f-a0af-4bd8-96cb-98ad31fb9db4",
  "subject_name": "django/db/models/functions/datetime::ExtractMinute",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractMinute(Extract)"
}
```
