# Fact 52e827e7

Store id: 4f56d1e5-02a2-4c2f-bc65-eaf1e2c12372

## Text

```text
def __init__(self, expression, number, **extra)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.1189860+00:00`

## Data

```json
{
  "end_line": 244,
  "entity_kind": "method",
  "parent": "Repeat",
  "start_line": 237,
  "symbol": "Repeat.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":237,"selector":"L237-L244","symbol":"Repeat.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Repeat.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 244,
    "entity_kind": "method",
    "parent": "Repeat",
    "start_line": 237,
    "symbol": "Repeat.__init__"
  },
  "id": "4f56d1e5-02a2-4c2f-bc65-eaf1e2c12372",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1189860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 237,
        "selector": "L237-L244",
        "symbol": "Repeat.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "a6bd8e1e-1dbc-4b7f-9521-963118c913a6",
  "subject_name": "django/db/models/functions/text::Repeat.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, number, **extra)"
}
```
