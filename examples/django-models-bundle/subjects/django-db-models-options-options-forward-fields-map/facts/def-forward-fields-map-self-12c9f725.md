# Fact 12c9f725

Store id: f1779e29-a449-4d4e-b467-fe23063e7a2e

## Text

```text
def _forward_fields_map(self)
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
- posted_at: `2026-11-09T22:39:48.8619700+00:00`

## Data

```json
{
  "end_line": 653,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 640,
  "symbol": "Options._forward_fields_map"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":640,"selector":"L640-L653","symbol":"Options._forward_fields_map"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options._forward_fields_map](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 653,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 640,
    "symbol": "Options._forward_fields_map"
  },
  "id": "f1779e29-a449-4d4e-b467-fe23063e7a2e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8619700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 640,
        "selector": "L640-L653",
        "symbol": "Options._forward_fields_map"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "69ce69be-975a-4a14-a775-aaf1ea02ffc2",
  "subject_name": "django/db/models/options::Options._forward_fields_map",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _forward_fields_map(self)"
}
```
