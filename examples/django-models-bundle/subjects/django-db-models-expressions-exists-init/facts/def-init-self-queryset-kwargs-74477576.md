# Fact 74477576

Store id: 92f015cd-f3c1-4482-946b-b60bc70842b1

## Text

```text
def __init__(self, queryset, **kwargs)
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
- posted_at: `2026-11-09T23:44:49.6478950+00:00`

## Data

```json
{
  "end_line": 1894,
  "entity_kind": "method",
  "parent": "Exists",
  "start_line": 1892,
  "symbol": "Exists.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1892,"selector":"L1892-L1894","symbol":"Exists.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Exists.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1894,
    "entity_kind": "method",
    "parent": "Exists",
    "start_line": 1892,
    "symbol": "Exists.__init__"
  },
  "id": "92f015cd-f3c1-4482-946b-b60bc70842b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6478950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1892,
        "selector": "L1892-L1894",
        "symbol": "Exists.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "16b99c22-a6b2-4ace-8e11-17ec8eccc61b",
  "subject_name": "django/db/models/expressions::Exists.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, queryset, **kwargs)"
}
```
