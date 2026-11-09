# Fact 74477576

Store id: eccea7a8-bedd-4bad-9446-e8cbe9f9bf6d

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
- posted_at: `2026-11-09T22:39:41.7354520+00:00`

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
  "id": "eccea7a8-bedd-4bad-9446-e8cbe9f9bf6d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7354520+00:00"
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
  "subject_id": "f05848f4-951e-4089-b77c-1804af7f662e",
  "subject_name": "django/db/models/expressions::Exists.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, queryset, **kwargs)"
}
```
