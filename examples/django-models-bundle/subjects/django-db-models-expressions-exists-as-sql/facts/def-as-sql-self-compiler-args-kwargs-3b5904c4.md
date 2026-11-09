# Fact 3b5904c4

Store id: 8333e635-1321-4321-ae34-9ea937ec33d9

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
- posted_at: `2026-11-09T22:39:41.7378380+00:00`

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
  "id": "8333e635-1321-4321-ae34-9ea937ec33d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7378380+00:00"
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
  "subject_id": "f1d13307-2c22-472b-886b-88e01c88c43f",
  "subject_name": "django/db/models/expressions::Exists.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, *args, **kwargs)"
}
```
