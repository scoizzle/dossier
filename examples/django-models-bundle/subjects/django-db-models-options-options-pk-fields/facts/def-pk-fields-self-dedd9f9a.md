# Fact dedd9f9a

Store id: e4fe2807-6e72-4baf-b704-3f53605b29c4

## Text

```text
def pk_fields(self)
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
- posted_at: `2026-11-09T23:32:04.0410660+00:00`

## Data

```json
{
  "end_line": 994,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 992,
  "symbol": "Options.pk_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":992,"selector":"L992-L994","symbol":"Options.pk_fields"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.pk_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 994,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 992,
    "symbol": "Options.pk_fields"
  },
  "id": "e4fe2807-6e72-4baf-b704-3f53605b29c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.0410660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 992,
        "selector": "L992-L994",
        "symbol": "Options.pk_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "cd3572ed-a230-4808-82a1-586b4b4402a6",
  "subject_name": "django/db/models/options::Options.pk_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def pk_fields(self)"
}
```
