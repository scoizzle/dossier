# Fact f84918f5

Store id: 22671a01-878f-42bb-9309-87ca3604dae5

## Text

```text
def __init__(self, expression, length, fill_text=Value(" "), **extra)
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
- posted_at: `2026-11-09T23:32:02.2121130+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "method",
  "parent": "LPad",
  "start_line": 201,
  "symbol": "LPad.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":201,"selector":"L201-L208","symbol":"LPad.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::LPad.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "method",
    "parent": "LPad",
    "start_line": 201,
    "symbol": "LPad.__init__"
  },
  "id": "22671a01-878f-42bb-9309-87ca3604dae5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2121130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 201,
        "selector": "L201-L208",
        "symbol": "LPad.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "a8cc5e08-2988-4345-b068-711d29ba6f1b",
  "subject_name": "django/db/models/functions/text::LPad.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, length, fill_text=Value(\" \"), **extra)"
}
```
