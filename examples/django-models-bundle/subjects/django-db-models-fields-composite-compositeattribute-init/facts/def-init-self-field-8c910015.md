# Fact 8c910015

Store id: ec292080-317a-48a3-8312-6107cb28a190

## Text

```text
def __init__(self, field)
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
- posted_at: `2026-11-09T22:39:42.9818030+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "method",
  "parent": "CompositeAttribute",
  "start_line": 24,
  "symbol": "CompositeAttribute.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":24,"selector":"L24-L25","symbol":"CompositeAttribute.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositeAttribute.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "method",
    "parent": "CompositeAttribute",
    "start_line": 24,
    "symbol": "CompositeAttribute.__init__"
  },
  "id": "ec292080-317a-48a3-8312-6107cb28a190",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9818030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 24,
        "selector": "L24-L25",
        "symbol": "CompositeAttribute.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "c0f79113-8b0c-4289-aa1e-9e9971c93092",
  "subject_name": "django/db/models/fields/composite::CompositeAttribute.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, field)"
}
```
