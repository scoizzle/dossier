# Fact e8917f8e

Store id: b04342eb-a4a9-4287-b04f-73ebb560b289

## Text

```text
def contribute_to_class(self, cls, name, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.6624890+00:00`

## Data

```json
{
  "end_line": 346,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 344,
  "symbol": "FileField.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":344,"selector":"L344-L346","symbol":"FileField.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 346,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 344,
    "symbol": "FileField.contribute_to_class"
  },
  "id": "b04342eb-a4a9-4287-b04f-73ebb560b289",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6624890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 344,
        "selector": "L344-L346",
        "symbol": "FileField.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "34a08d3d-e6e3-4aad-b3e8-0a0fc2460937",
  "subject_name": "django/db/models/fields/files::FileField.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, **kwargs)"
}
```
