# Fact f29e6fe4

Store id: f7d10853-2e5c-4e6a-9cb8-b20e1735c922

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
- posted_at: `2026-11-09T23:32:02.2589090+00:00`

## Data

```json
{
  "end_line": 279,
  "entity_kind": "method",
  "parent": "Reverse",
  "start_line": 264,
  "symbol": "Reverse.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":264,"selector":"L264-L279","symbol":"Reverse.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Reverse.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 279,
    "entity_kind": "method",
    "parent": "Reverse",
    "start_line": 264,
    "symbol": "Reverse.as_oracle"
  },
  "id": "f7d10853-2e5c-4e6a-9cb8-b20e1735c922",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2589090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 264,
        "selector": "L264-L279",
        "symbol": "Reverse.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "76d1f59a-92ad-4ca8-b7eb-4313296fb267",
  "subject_name": "django/db/models/functions/text::Reverse.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
