# Fact 14088adf

Store id: 50717957-1259-418d-a94c-530c9b45c3ff

## Text

```text
class Chr(Transform)
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
- posted_at: `2026-11-09T23:32:02.1368260+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 42,
  "symbol": "Chr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":42,"selector":"L42-L65","symbol":"Chr"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Chr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 42,
    "symbol": "Chr"
  },
  "id": "50717957-1259-418d-a94c-530c9b45c3ff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1368260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 42,
        "selector": "L42-L65",
        "symbol": "Chr"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "161034f5-87da-4e5e-9098-6310aec2b040",
  "subject_name": "django/db/models/functions/text::Chr",
  "tags": [
    "entity:class"
  ],
  "text": "class Chr(Transform)"
}
```
