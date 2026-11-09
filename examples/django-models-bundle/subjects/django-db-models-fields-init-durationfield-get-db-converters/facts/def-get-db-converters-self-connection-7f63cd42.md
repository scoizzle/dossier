# Fact 7f63cd42

Store id: 68919abf-e029-41f2-8880-662428d235a5

## Text

```text
def get_db_converters(self, connection)
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
- posted_at: `2026-11-09T23:31:56.6536150+00:00`

## Data

```json
{
  "end_line": 1982,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1978,
  "symbol": "DurationField.get_db_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1978,"selector":"L1978-L1982","symbol":"DurationField.get_db_converters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.get_db_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1982,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1978,
    "symbol": "DurationField.get_db_converters"
  },
  "id": "68919abf-e029-41f2-8880-662428d235a5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6536150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1978,
        "selector": "L1978-L1982",
        "symbol": "DurationField.get_db_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "7734dd79-a91f-495b-b8d3-cddd21465910",
  "subject_name": "django/db/models/fields/__init__::DurationField.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
