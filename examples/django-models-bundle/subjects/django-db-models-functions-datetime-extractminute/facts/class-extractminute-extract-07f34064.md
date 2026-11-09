# Fact 07f34064

Store id: bcd31a3e-1782-4172-8b34-a5dde0b6dae8

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
- posted_at: `2026-11-09T23:44:53.3622990+00:00`

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
  "id": "bcd31a3e-1782-4172-8b34-a5dde0b6dae8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3622990+00:00"
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
  "subject_id": "d4636aae-0876-4a64-ba60-9fb9c6a2b2f5",
  "subject_name": "django/db/models/functions/datetime::ExtractMinute",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractMinute(Extract)"
}
```
