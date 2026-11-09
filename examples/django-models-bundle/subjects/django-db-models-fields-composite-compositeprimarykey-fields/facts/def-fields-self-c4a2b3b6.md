# Fact c4a2b3b6

Store id: cb07b564-8640-41d6-8e07-d76943ad0f09

## Text

```text
def fields(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.4820640+00:00`

## Data

```json
{
  "end_line": 86,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 83,
  "symbol": "CompositePrimaryKey.fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":83,"selector":"L83-L86","symbol":"CompositePrimaryKey.fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 86,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 83,
    "symbol": "CompositePrimaryKey.fields"
  },
  "id": "cb07b564-8640-41d6-8e07-d76943ad0f09",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4820640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 83,
        "selector": "L83-L86",
        "symbol": "CompositePrimaryKey.fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "91427a33-7d99-42cc-90c4-2d3e44b469ea",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def fields(self)"
}
```
