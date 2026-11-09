# Fact 1712348e

Store id: 283f2132-2d76-4928-81ca-b19617cad8dd

## Text

```text
def _check_db_index(self)
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
- posted_at: `2026-11-09T23:31:56.4310990+00:00`

## Data

```json
{
  "end_line": 471,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 461,
  "symbol": "Field._check_db_index"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":461,"selector":"L461-L471","symbol":"Field._check_db_index"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_db_index](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 471,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 461,
    "symbol": "Field._check_db_index"
  },
  "id": "283f2132-2d76-4928-81ca-b19617cad8dd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4310990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 461,
        "selector": "L461-L471",
        "symbol": "Field._check_db_index"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "52860786-dbc4-448c-bf92-9982528777ff",
  "subject_name": "django/db/models/fields/__init__::Field._check_db_index",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_db_index(self)"
}
```
