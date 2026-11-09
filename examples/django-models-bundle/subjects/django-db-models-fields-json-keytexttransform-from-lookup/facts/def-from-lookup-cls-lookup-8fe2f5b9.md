# Fact 8fe2f5b9

Store id: f0289f0e-26b2-4517-b479-cfd2821cade5

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
- posted_at: `2026-11-09T23:31:57.9854360+00:00`

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
  "id": "f0289f0e-26b2-4517-b479-cfd2821cade5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9854360+00:00"
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
  "subject_id": "b25c2230-9cd0-40f1-b603-3fb4db44609c",
  "subject_name": "django/db/models/fields/json::KeyTextTransform.from_lookup",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def from_lookup(cls, lookup)"
}
```
