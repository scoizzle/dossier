# Fact 6dad6c75

Store id: e30760bd-153c-45ba-a6e6-3c7ba0272fb1

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
- posted_at: `2026-11-09T22:39:47.1532610+00:00`

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
  "id": "e30760bd-153c-45ba-a6e6-3c7ba0272fb1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1532610+00:00"
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
  "subject_id": "93524dea-b6f4-4524-908d-0a737916d09f",
  "subject_name": "django/db/models/functions/text::Replace.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, text, replacement=Value(\"\"), **extra)"
}
```
