# Fact e37f5c93

Store id: e5a2140f-5018-4b36-9edf-1a3e63d9820f

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
- posted_at: `2026-11-09T23:31:53.7550830+00:00`

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
  "id": "e5a2140f-5018-4b36-9edf-1a3e63d9820f",
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
    "posted_at": "2026-11-09T23:31:53.7550830+00:00"
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
  "subject_id": "68e759c9-2763-469a-be67-24f4113de0cc",
  "subject_name": "django/db/models/base::Model._get_unique_checks",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_unique_checks(self, exclude=None, include_meta_constraints=False)"
}
```
