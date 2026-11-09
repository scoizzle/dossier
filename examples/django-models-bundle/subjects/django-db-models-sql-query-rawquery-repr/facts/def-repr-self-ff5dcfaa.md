# Fact ff5dcfaa

Store id: 6fcbaae8-1089-4bb9-b9dd-7b5b0934e133

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:32:06.7247080+00:00`

## Data

```json
{
  "end_line": 195,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 194,
  "symbol": "RawQuery.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":194,"selector":"L194-L195","symbol":"RawQuery.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 195,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 194,
    "symbol": "RawQuery.__repr__"
  },
  "id": "6fcbaae8-1089-4bb9-b9dd-7b5b0934e133",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7247080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 194,
        "selector": "L194-L195",
        "symbol": "RawQuery.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e407458b-d811-450c-a3db-8f285ff938aa",
  "subject_name": "django/db/models/sql/query::RawQuery.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
