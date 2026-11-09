# Fact 1eaea593

Store id: b95e9192-193a-4390-aa2a-52d6fba84a49

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
- posted_at: `2026-11-09T23:44:54.1467580+00:00`

## Data

```json
{
  "end_line": 312,
  "entity_kind": "method",
  "parent": "SHA224",
  "start_line": 311,
  "symbol": "SHA224.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":311,"selector":"L311-L312","symbol":"SHA224.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::SHA224.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 312,
    "entity_kind": "method",
    "parent": "SHA224",
    "start_line": 311,
    "symbol": "SHA224.as_oracle"
  },
  "id": "b95e9192-193a-4390-aa2a-52d6fba84a49",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1467580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 311,
        "selector": "L311-L312",
        "symbol": "SHA224.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "298484e7-d8e9-457b-bc32-78980b26b41e",
  "subject_name": "django/db/models/functions/text::SHA224.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
