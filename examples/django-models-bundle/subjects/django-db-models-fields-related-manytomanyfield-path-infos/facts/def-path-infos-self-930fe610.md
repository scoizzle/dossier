# Fact 930fe610

Store id: 7b8ab4e6-5764-44e6-8549-481cc82cb1fd

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
- posted_at: `2026-11-09T22:39:44.4763970+00:00`

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
  "id": "7b8ab4e6-5764-44e6-8549-481cc82cb1fd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4763970+00:00"
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
  "subject_id": "2a7a81e5-d6b6-4dd7-830c-3c157143d36d",
  "subject_name": "django/db/models/fields/related::ManyToManyField.path_infos",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def path_infos(self)"
}
```
