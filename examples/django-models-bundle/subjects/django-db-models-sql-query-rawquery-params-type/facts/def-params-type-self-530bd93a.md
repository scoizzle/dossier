# Fact 530bd93a

Store id: bc63063b-a8af-4252-80d4-a3d96036bc84

## Text

```text
def params_type(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:58.5709600+00:00`

## Data

```json
{
  "end_line": 201,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 197,
  "symbol": "RawQuery.params_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":197,"selector":"L197-L201","symbol":"RawQuery.params_type"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.params_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 201,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 197,
    "symbol": "RawQuery.params_type"
  },
  "id": "bc63063b-a8af-4252-80d4-a3d96036bc84",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5709600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 197,
        "selector": "L197-L201",
        "symbol": "RawQuery.params_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a2e64664-a454-4f00-9cbc-cfea51d593d2",
  "subject_name": "django/db/models/sql/query::RawQuery.params_type",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def params_type(self)"
}
```
