# Fact e7a61ebe

Store id: 53f274ea-284d-481e-bbd7-5e35df90d39b

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
- posted_at: `2026-11-09T23:44:51.5523400+00:00`

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
  "id": "53f274ea-284d-481e-bbd7-5e35df90d39b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5523400+00:00"
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
  "subject_id": "2b624bd1-0c02-4da5-a7f7-2f50a3e958e3",
  "subject_name": "django/db/models/fields/related::ForeignObject.path_infos",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def path_infos(self)"
}
```
