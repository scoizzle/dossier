# Fact 568799c7

Store id: 91a0bfad-7fc5-4238-a6ac-ae8350500d74

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T22:39:41.6944700+00:00`

## Data

```json
{
  "end_line": 1671,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1670,
  "symbol": "When.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1670,"selector":"L1670-L1671","symbol":"When.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1671,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1670,
    "symbol": "When.set_source_expressions"
  },
  "id": "91a0bfad-7fc5-4238-a6ac-ae8350500d74",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6944700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1670,
        "selector": "L1670-L1671",
        "symbol": "When.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a9819a0a-ca7e-4f42-90e4-4cb5958a5bb6",
  "subject_name": "django/db/models/expressions::When.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
