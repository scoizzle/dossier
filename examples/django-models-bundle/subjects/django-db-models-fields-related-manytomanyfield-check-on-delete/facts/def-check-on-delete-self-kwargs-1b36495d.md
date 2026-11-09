# Fact 1b36495d

Store id: 9286eb71-4ca7-4b9c-be2f-989f9798c2f2

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
- posted_at: `2026-11-09T23:31:58.8466970+00:00`

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
  "id": "9286eb71-4ca7-4b9c-be2f-989f9798c2f2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8466970+00:00"
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
  "subject_id": "86eac1d9-ccbf-4efc-9d8a-880373232330",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_on_delete",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_on_delete(self, **kwargs)"
}
```
