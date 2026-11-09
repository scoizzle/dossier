# Fact 43b8dfa8

Store id: fcf8537c-ec9d-4dd3-b4b0-1561b496d6d0

## Text

```text
def external_aliases(self)
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
- posted_at: `2026-11-09T22:39:41.7274700+00:00`

## Data

```json
{
  "end_line": 1868,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1866,
  "symbol": "Subquery.external_aliases"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1866,"selector":"L1866-L1868","symbol":"Subquery.external_aliases"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.external_aliases](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1868,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1866,
    "symbol": "Subquery.external_aliases"
  },
  "id": "fcf8537c-ec9d-4dd3-b4b0-1561b496d6d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7274700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1866,
        "selector": "L1866-L1868",
        "symbol": "Subquery.external_aliases"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a24b30b0-5225-41dc-95aa-a5811194640d",
  "subject_name": "django/db/models/expressions::Subquery.external_aliases",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def external_aliases(self)"
}
```
