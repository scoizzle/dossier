# Fact e37f5c93

Store id: d91a204f-e3c1-447a-a58c-a20fed216db9

## Text

```text
def _get_unique_checks(self, exclude=None, include_meta_constraints=False)
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
- posted_at: `2026-11-09T22:39:40.3487860+00:00`

## Data

```json
{
  "end_line": 1542,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1476,
  "symbol": "Model._get_unique_checks"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1476,"selector":"L1476-L1542","symbol":"Model._get_unique_checks"}`

## Items

```json
[
  {
    "text": "Return a list of checks to perform. Since validate_unique() could be called from a ModelForm, some fields may have been excluded; we can't perform a unique check on a model that is missing fields involved in that check. Fields that did not validate should also be excluded, but they need to be passed in via the exclude argument.",
    "locator": {
      "line": 1477
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._get_unique_checks](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1542,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1476,
    "symbol": "Model._get_unique_checks"
  },
  "id": "d91a204f-e3c1-447a-a58c-a20fed216db9",
  "items": [
    {
      "locator": {
        "line": 1477
      },
      "text": "Return a list of checks to perform. Since validate_unique() could be called from a ModelForm, some fields may have been excluded; we can't perform a unique check on a model that is missing fields involved in that check. Fields that did not validate should also be excluded, but they need to be passed in via the exclude argument."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3487860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1476,
        "selector": "L1476-L1542",
        "symbol": "Model._get_unique_checks"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "f5990186-2ba9-416b-b624-c0359c9a78b7",
  "subject_name": "django/db/models/base::Model._get_unique_checks",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_unique_checks(self, exclude=None, include_meta_constraints=False)"
}
```
