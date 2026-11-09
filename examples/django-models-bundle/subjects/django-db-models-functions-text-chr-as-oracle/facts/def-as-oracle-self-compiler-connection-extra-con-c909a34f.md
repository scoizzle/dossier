# Fact c909a34f

Store id: 9efb1901-24c2-4b1c-9968-ffdefa54fcb0

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:02.1442530+00:00`

## Data

```json
{
  "end_line": 62,
  "entity_kind": "method",
  "parent": "Chr",
  "start_line": 56,
  "symbol": "Chr.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":56,"selector":"L56-L62","symbol":"Chr.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Chr.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 62,
    "entity_kind": "method",
    "parent": "Chr",
    "start_line": 56,
    "symbol": "Chr.as_oracle"
  },
  "id": "9efb1901-24c2-4b1c-9968-ffdefa54fcb0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1442530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 56,
        "selector": "L56-L62",
        "symbol": "Chr.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "c7fbe64b-b7bb-47e2-9a23-36398bb55d5d",
  "subject_name": "django/db/models/functions/text::Chr.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
