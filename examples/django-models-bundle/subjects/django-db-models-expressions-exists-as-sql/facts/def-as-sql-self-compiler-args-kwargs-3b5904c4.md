# Fact 3b5904c4

Store id: 94448916-f39d-4b22-9518-50b2cc3ba3f7

## Text

```text
def as_sql(self, compiler, *args, **kwargs)
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
- posted_at: `2026-11-09T23:31:55.9831470+00:00`

## Data

```json
{
  "end_line": 1911,
  "entity_kind": "method",
  "parent": "Exists",
  "start_line": 1904,
  "symbol": "Exists.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1904,"selector":"L1904-L1911","symbol":"Exists.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Exists.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1911,
    "entity_kind": "method",
    "parent": "Exists",
    "start_line": 1904,
    "symbol": "Exists.as_sql"
  },
  "id": "94448916-f39d-4b22-9518-50b2cc3ba3f7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9831470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1904,
        "selector": "L1904-L1911",
        "symbol": "Exists.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "afb8d233-b0a6-451c-91a9-ff6b55376dbd",
  "subject_name": "django/db/models/expressions::Exists.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, *args, **kwargs)"
}
```
