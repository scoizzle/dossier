# Fact fd38a992

Store id: f93547a0-8dd8-4601-8c65-bc9f121010cb

## Text

```text
def _check_db_comment(self, databases=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.2793640+00:00`

## Data

```json
{
  "end_line": 493,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 473,
  "symbol": "Field._check_db_comment"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":473,"selector":"L473-L493","symbol":"Field._check_db_comment"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_db_comment](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 493,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 473,
    "symbol": "Field._check_db_comment"
  },
  "id": "f93547a0-8dd8-4601-8c65-bc9f121010cb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2793640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 473,
        "selector": "L473-L493",
        "symbol": "Field._check_db_comment"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f94313d9-620a-4470-9fe5-fc75683d6409",
  "subject_name": "django/db/models/fields/__init__::Field._check_db_comment",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_db_comment(self, databases=None, **kwargs)"
}
```
