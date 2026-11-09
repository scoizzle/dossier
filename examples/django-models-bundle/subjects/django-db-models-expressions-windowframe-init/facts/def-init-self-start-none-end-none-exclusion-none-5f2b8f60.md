# Fact 5f2b8f60

Store id: 0ce30197-449f-4664-ad63-b6fb28a467d5

## Text

```text
def __init__(self, start=None, end=None, exclusion=None)
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
- posted_at: `2026-11-09T23:31:56.0148160+00:00`

## Data

```json
{
  "end_line": 2156,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2148,
  "symbol": "WindowFrame.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2148,"selector":"L2148-L2156","symbol":"WindowFrame.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2156,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2148,
    "symbol": "WindowFrame.__init__"
  },
  "id": "0ce30197-449f-4664-ad63-b6fb28a467d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0148160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2148,
        "selector": "L2148-L2156",
        "symbol": "WindowFrame.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8a16d8f6-3c32-4ea7-8e36-c614f66cd3df",
  "subject_name": "django/db/models/expressions::WindowFrame.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, start=None, end=None, exclusion=None)"
}
```
