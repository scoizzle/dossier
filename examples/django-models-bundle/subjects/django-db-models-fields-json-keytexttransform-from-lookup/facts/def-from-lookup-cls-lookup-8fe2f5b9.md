# Fact 8fe2f5b9

Store id: e436a26b-a51f-4c26-b710-88b5ae8c8166

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
- posted_at: `2026-11-09T23:44:51.0318290+00:00`

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
  "id": "e436a26b-a51f-4c26-b710-88b5ae8c8166",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0318290+00:00"
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
  "subject_id": "8276e81f-fbe4-44e8-8990-cbe24e92ff8a",
  "subject_name": "django/db/models/fields/json::KeyTextTransform.from_lookup",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def from_lookup(cls, lookup)"
}
```
