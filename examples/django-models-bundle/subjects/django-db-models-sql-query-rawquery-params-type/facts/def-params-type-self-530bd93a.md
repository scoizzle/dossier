# Fact 530bd93a

Store id: 192980de-bd09-4bf5-98f5-83fee9b26f77

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
- posted_at: `2026-11-09T22:39:51.2068880+00:00`

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
  "id": "192980de-bd09-4bf5-98f5-83fee9b26f77",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2068880+00:00"
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
  "subject_id": "7769623e-e2fb-4678-9e7d-7d374d9c72ea",
  "subject_name": "django/db/models/sql/query::RawQuery.params_type",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def params_type(self)"
}
```
