# Fact 4f39702f

Store id: 3cce868f-aef7-4ecf-aaa1-3b12b0713e94

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
- posted_at: `2026-11-09T23:32:02.2439240+00:00`

## Data

```json
{
  "end_line": 250,
  "entity_kind": "method",
  "parent": "Repeat",
  "start_line": 246,
  "symbol": "Repeat.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":246,"selector":"L246-L250","symbol":"Repeat.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Repeat.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 250,
    "entity_kind": "method",
    "parent": "Repeat",
    "start_line": 246,
    "symbol": "Repeat.as_oracle"
  },
  "id": "3cce868f-aef7-4ecf-aaa1-3b12b0713e94",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2439240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 246,
        "selector": "L246-L250",
        "symbol": "Repeat.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "721615b6-de26-45e3-95b0-8c5e3ca3525a",
  "subject_name": "django/db/models/functions/text::Repeat.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
