# Fact 930fe610

Store id: f0eb0634-28cc-4f96-b22d-7f596ab4ac57

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
- posted_at: `2026-11-09T23:31:58.8636980+00:00`

## Data

```json
{
  "end_line": 2031,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2029,
  "symbol": "ManyToManyField.path_infos"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2029,"selector":"L2029-L2031","symbol":"ManyToManyField.path_infos"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.path_infos](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2031,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2029,
    "symbol": "ManyToManyField.path_infos"
  },
  "id": "f0eb0634-28cc-4f96-b22d-7f596ab4ac57",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8636980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2029,
        "selector": "L2029-L2031",
        "symbol": "ManyToManyField.path_infos"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "c450d8e2-9692-4953-9640-0551d32ecb0c",
  "subject_name": "django/db/models/fields/related::ManyToManyField.path_infos",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def path_infos(self)"
}
```
