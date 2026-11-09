# Fact 6dad6c75

Store id: 4f44f9c7-f795-425c-90d2-31f229617ebf

## Text

```text
def __init__(self, expression, text, replacement=Value(""), **extra)
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
- posted_at: `2026-11-09T23:32:02.2521170+00:00`

## Data

```json
{
  "end_line": 257,
  "entity_kind": "method",
  "parent": "Replace",
  "start_line": 256,
  "symbol": "Replace.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":256,"selector":"L256-L257","symbol":"Replace.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Replace.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 257,
    "entity_kind": "method",
    "parent": "Replace",
    "start_line": 256,
    "symbol": "Replace.__init__"
  },
  "id": "4f44f9c7-f795-425c-90d2-31f229617ebf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2521170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 256,
        "selector": "L256-L257",
        "symbol": "Replace.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "34918b13-340d-4db1-b284-564e06081bcf",
  "subject_name": "django/db/models/functions/text::Replace.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, text, replacement=Value(\"\"), **extra)"
}
```
