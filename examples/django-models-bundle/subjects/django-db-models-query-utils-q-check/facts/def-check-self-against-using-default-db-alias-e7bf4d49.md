# Fact e7bf4d49

Store id: 1f493cbf-2687-4e6b-9efc-91a415dd7e2c

## Text

```text
def check(self, against, using=DEFAULT_DB_ALIAS)
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
- posted_at: `2026-11-09T23:32:05.0838330+00:00`

## Data

```json
{
  "end_line": 201,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 171,
  "symbol": "Q.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":171,"selector":"L171-L201","symbol":"Q.check"}`

## Items

```json
[
  {
    "text": "Do a database query to check if the expressions of the Q instance matches against the expressions.",
    "locator": {
      "line": 172
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 201,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 171,
    "symbol": "Q.check"
  },
  "id": "1f493cbf-2687-4e6b-9efc-91a415dd7e2c",
  "items": [
    {
      "locator": {
        "line": 172
      },
      "text": "Do a database query to check if the expressions of the Q instance matches against the expressions."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0838330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 171,
        "selector": "L171-L201",
        "symbol": "Q.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "c8ef0eef-02fd-4777-8989-be86b739a2c6",
  "subject_name": "django/db/models/query_utils::Q.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, against, using=DEFAULT_DB_ALIAS)"
}
```
