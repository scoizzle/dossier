# Fact 1b36495d

Store id: d0b8a516-f61f-4c81-a5a5-89a8d0600432

## Text

```text
def _check_on_delete(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.6434840+00:00`

## Data

```json
{
  "end_line": 1947,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1905,
  "symbol": "ManyToManyField._check_on_delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1905,"selector":"L1905-L1947","symbol":"ManyToManyField._check_on_delete"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_on_delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1947,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1905,
    "symbol": "ManyToManyField._check_on_delete"
  },
  "id": "d0b8a516-f61f-4c81-a5a5-89a8d0600432",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6434840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1905,
        "selector": "L1905-L1947",
        "symbol": "ManyToManyField._check_on_delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "2e52c711-adf0-4723-a863-bad673760dae",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_on_delete",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_on_delete(self, **kwargs)"
}
```
