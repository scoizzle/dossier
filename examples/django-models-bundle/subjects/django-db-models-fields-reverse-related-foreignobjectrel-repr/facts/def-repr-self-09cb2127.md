# Fact 09cb2127

Store id: 97bbd963-d41d-4d5c-89ec-732b0223e408

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:45.3319140+00:00`

## Data

```json
{
  "end_line": 136,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 131,
  "symbol": "ForeignObjectRel.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":131,"selector":"L131-L136","symbol":"ForeignObjectRel.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 136,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 131,
    "symbol": "ForeignObjectRel.__repr__"
  },
  "id": "97bbd963-d41d-4d5c-89ec-732b0223e408",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3319140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 131,
        "selector": "L131-L136",
        "symbol": "ForeignObjectRel.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "e093a780-2c48-47b4-9663-44374b77973f",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
