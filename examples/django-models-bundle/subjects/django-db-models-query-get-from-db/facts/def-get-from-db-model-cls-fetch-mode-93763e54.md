# Fact 93763e54

Store id: d3c9a5f0-4575-4f01-97dd-89eae4b32e99

## Text

```text
def _get_from_db(model_cls, fetch_mode)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.7436470+00:00`

## Data

```json
{
  "end_line": 82,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 60,
  "symbol": "_get_from_db"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":60,"selector":"L60-L82","symbol":"_get_from_db"}`

## Items

```json
[
  {
    "text": "Return a callable equivalent to model_cls.from_db with fetch_mode already bound, accommodating deprecated from_db() overrides that don't accept the fetch_mode keyword argument.",
    "locator": {
      "line": 61
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::_get_from_db](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 82,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 60,
    "symbol": "_get_from_db"
  },
  "id": "d3c9a5f0-4575-4f01-97dd-89eae4b32e99",
  "items": [
    {
      "locator": {
        "line": 61
      },
      "text": "Return a callable equivalent to model_cls.from_db with fetch_mode already bound, accommodating deprecated from_db() overrides that don't accept the fetch_mode keyword argument."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.7436470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 60,
        "selector": "L60-L82",
        "symbol": "_get_from_db"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1239b777-34b5-4ad5-ad1d-8dc026a1fc0b",
  "subject_name": "django/db/models/query::_get_from_db",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_from_db(model_cls, fetch_mode)"
}
```
