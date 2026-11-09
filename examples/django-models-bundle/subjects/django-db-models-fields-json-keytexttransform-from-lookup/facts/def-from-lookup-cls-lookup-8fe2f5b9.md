# Fact 8fe2f5b9

Store id: 3fa4cf1c-da58-48a5-8edc-a7ef226f496c

## Text

```text
def from_lookup(cls, lookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.7200770+00:00`

## Data

```json
{
  "end_line": 566,
  "entity_kind": "class_method",
  "parent": "KeyTextTransform",
  "start_line": 559,
  "symbol": "KeyTextTransform.from_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":559,"selector":"L559-L566","symbol":"KeyTextTransform.from_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTextTransform.from_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 566,
    "entity_kind": "class_method",
    "parent": "KeyTextTransform",
    "start_line": 559,
    "symbol": "KeyTextTransform.from_lookup"
  },
  "id": "3fa4cf1c-da58-48a5-8edc-a7ef226f496c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7200770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 559,
        "selector": "L559-L566",
        "symbol": "KeyTextTransform.from_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "adfd5a1b-82c8-485e-a335-9143042f7c93",
  "subject_name": "django/db/models/fields/json::KeyTextTransform.from_lookup",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def from_lookup(cls, lookup)"
}
```
