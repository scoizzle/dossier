# Fact 2e13ad43

Store id: 87fbe3ae-db30-4e32-ab0b-25b51e88031a

## Text

```text
def _get_default_pk_class(self)
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
- posted_at: `2026-11-09T23:44:55.4828940+00:00`

## Data

```json
{
  "end_line": 290,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 261,
  "symbol": "Options._get_default_pk_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":261,"selector":"L261-L290","symbol":"Options._get_default_pk_class"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options._get_default_pk_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 290,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 261,
    "symbol": "Options._get_default_pk_class"
  },
  "id": "87fbe3ae-db30-4e32-ab0b-25b51e88031a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4828940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 261,
        "selector": "L261-L290",
        "symbol": "Options._get_default_pk_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "47cc5032-4cfc-4ca5-9c39-0692cf32374d",
  "subject_name": "django/db/models/options::Options._get_default_pk_class",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_default_pk_class(self)"
}
```
