# Fact d006a5b1

Store id: a2450db9-fcfc-4f9e-898d-f279e6917bbc

## Text

```text
def __and__(self, other)
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
- posted_at: `2026-11-09T22:39:41.4771210+00:00`

## Data

```json
{
  "end_line": 102,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 97,
  "symbol": "Combinable.__and__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":97,"selector":"L97-L102","symbol":"Combinable.__and__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__and__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 102,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 97,
    "symbol": "Combinable.__and__"
  },
  "id": "a2450db9-fcfc-4f9e-898d-f279e6917bbc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4771210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 97,
        "selector": "L97-L102",
        "symbol": "Combinable.__and__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "43ebae24-9a5e-4549-b6d4-7bd5c20c5c21",
  "subject_name": "django/db/models/expressions::Combinable.__and__",
  "tags": [
    "entity:method"
  ],
  "text": "def __and__(self, other)"
}
```
