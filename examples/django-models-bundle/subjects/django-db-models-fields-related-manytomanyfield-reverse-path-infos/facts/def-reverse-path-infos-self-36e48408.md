# Fact 36e48408

Store id: 572ea962-7844-465e-a7a9-8129a51a83e5

## Text

```text
def reverse_path_infos(self)
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
- posted_at: `2026-11-09T23:44:51.6578460+00:00`

## Data

```json
{
  "end_line": 2038,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2036,
  "symbol": "ManyToManyField.reverse_path_infos"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2036,"selector":"L2036-L2038","symbol":"ManyToManyField.reverse_path_infos"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.reverse_path_infos](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2038,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2036,
    "symbol": "ManyToManyField.reverse_path_infos"
  },
  "id": "572ea962-7844-465e-a7a9-8129a51a83e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6578460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2036,
        "selector": "L2036-L2038",
        "symbol": "ManyToManyField.reverse_path_infos"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "72e9cc3f-d894-4962-92e0-4511f3ecdf91",
  "subject_name": "django/db/models/fields/related::ManyToManyField.reverse_path_infos",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def reverse_path_infos(self)"
}
```
