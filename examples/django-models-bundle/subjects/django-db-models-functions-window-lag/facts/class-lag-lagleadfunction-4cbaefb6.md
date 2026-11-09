# Fact 4cbaefb6

Store id: 5da892c1-f4cd-491a-ac60-856755ae4b62

## Text

```text
class Lag(LagLeadFunction)
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
- posted_at: `2026-11-09T23:32:02.6971970+00:00`

## Data

```json
{
  "end_line": 61,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 60,
  "symbol": "Lag"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":60,"selector":"L60-L61","symbol":"Lag"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::Lag](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 61,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 60,
    "symbol": "Lag"
  },
  "id": "5da892c1-f4cd-491a-ac60-856755ae4b62",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.6971970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 60,
        "selector": "L60-L61",
        "symbol": "Lag"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "e4c37dcf-880b-4e34-9e78-482d2c354ec9",
  "subject_name": "django/db/models/functions/window::Lag",
  "tags": [
    "entity:class"
  ],
  "text": "class Lag(LagLeadFunction)"
}
```
