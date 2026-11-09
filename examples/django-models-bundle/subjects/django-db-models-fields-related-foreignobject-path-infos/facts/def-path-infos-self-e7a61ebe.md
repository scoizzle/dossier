# Fact e7a61ebe

Store id: a9b32c20-5d2c-440f-a17a-a42b21f1189e

## Text

```text
def path_infos(self)
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
- posted_at: `2026-11-09T23:31:58.7219420+00:00`

## Data

```json
{
  "end_line": 909,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 907,
  "symbol": "ForeignObject.path_infos"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":907,"selector":"L907-L909","symbol":"ForeignObject.path_infos"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.path_infos](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 909,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 907,
    "symbol": "ForeignObject.path_infos"
  },
  "id": "a9b32c20-5d2c-440f-a17a-a42b21f1189e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7219420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 907,
        "selector": "L907-L909",
        "symbol": "ForeignObject.path_infos"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "58633c2a-a15d-473f-b42d-be018711a603",
  "subject_name": "django/db/models/fields/related::ForeignObject.path_infos",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def path_infos(self)"
}
```
