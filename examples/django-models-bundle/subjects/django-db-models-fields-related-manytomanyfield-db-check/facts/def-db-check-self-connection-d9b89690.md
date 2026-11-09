# Fact d9b89690

Store id: ccb669af-ca15-4052-87cf-f651b8933832

## Text

```text
def db_check(self, connection)
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
- posted_at: `2026-11-09T23:44:51.6797280+00:00`

## Data

```json
{
  "end_line": 2204,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2203,
  "symbol": "ManyToManyField.db_check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2203,"selector":"L2203-L2204","symbol":"ManyToManyField.db_check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.db_check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2204,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2203,
    "symbol": "ManyToManyField.db_check"
  },
  "id": "ccb669af-ca15-4052-87cf-f651b8933832",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6797280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2203,
        "selector": "L2203-L2204",
        "symbol": "ManyToManyField.db_check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "27e0dcd1-05e8-47e9-9f5e-ff465f0ea89a",
  "subject_name": "django/db/models/fields/related::ManyToManyField.db_check",
  "tags": [
    "entity:method"
  ],
  "text": "def db_check(self, connection)"
}
```
