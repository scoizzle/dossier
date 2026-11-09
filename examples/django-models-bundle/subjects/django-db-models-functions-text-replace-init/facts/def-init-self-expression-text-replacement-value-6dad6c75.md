# Fact 6dad6c75

Store id: a6aa0e23-3ab9-47a1-b8f6-536ba71322cc

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
- posted_at: `2026-11-09T23:44:54.1257110+00:00`

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
  "id": "a6aa0e23-3ab9-47a1-b8f6-536ba71322cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1257110+00:00"
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
  "subject_id": "14b23642-5812-451f-a419-e944e21da410",
  "subject_name": "django/db/models/functions/text::Replace.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, text, replacement=Value(\"\"), **extra)"
}
```
