# Fact dedd9f9a

Store id: 9a4b01d4-50eb-4df4-a949-a1719659f53a

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
- posted_at: `2026-11-09T22:39:48.9642360+00:00`

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
  "id": "9a4b01d4-50eb-4df4-a949-a1719659f53a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.9642360+00:00"
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
  "subject_id": "b2421fdf-10fa-49f3-ac1c-35bf1319045c",
  "subject_name": "django/db/models/options::Options.pk_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def pk_fields(self)"
}
```
