# Fact dc6593a4

Store id: a78fa962-fb71-45f3-9c26-a792ddd07fb1

## Text

```text
def __rxor__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2611590+00:00`

## Data

```json
{
  "end_line": 164,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 161,
  "symbol": "Combinable.__rxor__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":161,"selector":"L161-L164","symbol":"Combinable.__rxor__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rxor__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 164,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 161,
    "symbol": "Combinable.__rxor__"
  },
  "id": "a78fa962-fb71-45f3-9c26-a792ddd07fb1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2611590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 161,
        "selector": "L161-L164",
        "symbol": "Combinable.__rxor__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "7018d863-0157-4b37-afef-50e9e906f32b",
  "subject_name": "django/db/models/expressions::Combinable.__rxor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rxor__(self, other)"
}
```
