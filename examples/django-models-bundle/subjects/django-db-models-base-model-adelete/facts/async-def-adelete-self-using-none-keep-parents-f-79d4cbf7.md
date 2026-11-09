# Fact 79d4cbf7

Store id: eab93543-bdbc-48de-8bdf-4bd909bcac31

## Text

```text
async def adelete(self, using=None, keep_parents=False)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.7499870+00:00`

## Data

```json
{
  "end_line": 1341,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1337,
  "symbol": "Model.adelete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1337,"selector":"L1337-L1341","symbol":"Model.adelete"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.adelete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1341,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1337,
    "symbol": "Model.adelete"
  },
  "id": "eab93543-bdbc-48de-8bdf-4bd909bcac31",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7499870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1337,
        "selector": "L1337-L1341",
        "symbol": "Model.adelete"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "40511359-a968-4df3-b2c4-5324cd69e717",
  "subject_name": "django/db/models/base::Model.adelete",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def adelete(self, using=None, keep_parents=False)"
}
```
